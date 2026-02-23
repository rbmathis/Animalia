using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pipidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pipidae.Hymenochirus;

/// <summary>
/// Abstract class for Hymenochirus (genus).
/// NCBI TaxId: 8361
/// </summary>
public abstract class Hymenochirus : Pipidae, IHymenochirus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hymenochirus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8361;

    /// <inheritdoc />
    public virtual string GenusName => "Hymenochirus";

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
