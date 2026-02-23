using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Chrysophlegma;

/// <summary>
/// Abstract class for Chrysophlegma (genus).
/// NCBI TaxId: 1517838
/// </summary>
public abstract class Chrysophlegma : Picidae, IChrysophlegma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chrysophlegma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1517838;

    /// <inheritdoc />
    public virtual string GenusName => "Chrysophlegma";

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
