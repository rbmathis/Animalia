using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Paralichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Paralichthyidae.Paralichthys;

/// <summary>
/// Abstract class for Paralichthys (genus).
/// NCBI TaxId: 8254
/// </summary>
public abstract class Paralichthys : Paralichthyidae, IParalichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paralichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8254;

    /// <inheritdoc />
    public virtual string GenusName => "Paralichthys";

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
