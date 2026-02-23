using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Ptilichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Ptilichthyidae.Ptilichthys;

/// <summary>
/// Abstract class for Ptilichthys (genus).
/// NCBI TaxId: 641288
/// </summary>
public abstract class Ptilichthys : Ptilichthyidae, IPtilichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ptilichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 641288;

    /// <inheritdoc />
    public virtual string GenusName => "Ptilichthys";

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
