using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Danakilia;

/// <summary>
/// Abstract class for Danakilia (genus).
/// NCBI TaxId: 1315726
/// </summary>
public abstract class Danakilia : Cichlidae, IDanakilia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Danakilia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1315726;

    /// <inheritdoc />
    public virtual string GenusName => "Danakilia";

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
