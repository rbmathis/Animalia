using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Coturnix;

/// <summary>
/// Abstract class for Coturnix (genus).
/// NCBI TaxId: 9090
/// </summary>
public abstract class Coturnix : Phasianidae, ICoturnix
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Coturnix";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9090;

    /// <inheritdoc />
    public virtual string GenusName => "Coturnix";

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
