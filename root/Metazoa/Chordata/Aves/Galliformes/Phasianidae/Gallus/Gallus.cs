using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Gallus;

/// <summary>
/// Abstract class for Gallus (genus).
/// NCBI TaxId: 9030
/// </summary>
public abstract class Gallus : Phasianidae, IGallus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gallus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9030;

    /// <inheritdoc />
    public virtual string GenusName => "Gallus";

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
