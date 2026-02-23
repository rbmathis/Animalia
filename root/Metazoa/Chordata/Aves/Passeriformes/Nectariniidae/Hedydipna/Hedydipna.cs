using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Nectariniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Nectariniidae.Hedydipna;

/// <summary>
/// Abstract class for Hedydipna (genus).
/// NCBI TaxId: 570450
/// </summary>
public abstract class Hedydipna : Nectariniidae, IHedydipna
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hedydipna";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 570450;

    /// <inheritdoc />
    public virtual string GenusName => "Hedydipna";

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
