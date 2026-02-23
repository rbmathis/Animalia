using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Balistidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Balistidae.Rhinecanthus;

/// <summary>
/// Abstract class for Rhinecanthus (genus).
/// NCBI TaxId: 245704
/// </summary>
public abstract class Rhinecanthus : Balistidae, IRhinecanthus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhinecanthus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 245704;

    /// <inheritdoc />
    public virtual string GenusName => "Rhinecanthus";

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
