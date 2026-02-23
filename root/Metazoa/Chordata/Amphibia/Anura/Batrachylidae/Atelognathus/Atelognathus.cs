using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Batrachylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Batrachylidae.Atelognathus;

/// <summary>
/// Abstract class for Atelognathus (genus).
/// NCBI TaxId: 318266
/// </summary>
public abstract class Atelognathus : Batrachylidae, IAtelognathus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Atelognathus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 318266;

    /// <inheritdoc />
    public virtual string GenusName => "Atelognathus";

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
