using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Hoplichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Hoplichthyidae.Hoplichthys;

/// <summary>
/// Abstract class for Hoplichthys (genus).
/// NCBI TaxId: 270557
/// </summary>
public abstract class Hoplichthys : Hoplichthyidae, IHoplichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hoplichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 270557;

    /// <inheritdoc />
    public virtual string GenusName => "Hoplichthys";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
