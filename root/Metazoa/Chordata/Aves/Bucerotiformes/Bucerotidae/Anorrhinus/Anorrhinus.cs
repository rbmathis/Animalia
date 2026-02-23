using AnimalKingdom.root.Metazoa.Chordata.Aves.Bucerotiformes.Bucerotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Bucerotiformes.Bucerotidae.Anorrhinus;

/// <summary>
/// Abstract class for Anorrhinus (genus).
/// NCBI TaxId: 866354
/// </summary>
public abstract class Anorrhinus : Bucerotidae, IAnorrhinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anorrhinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 866354;

    /// <inheritdoc />
    public virtual string GenusName => "Anorrhinus";

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
