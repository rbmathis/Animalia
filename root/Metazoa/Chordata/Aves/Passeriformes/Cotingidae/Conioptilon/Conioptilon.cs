using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cotingidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cotingidae.Conioptilon;

/// <summary>
/// Abstract class for Conioptilon (genus).
/// NCBI TaxId: 114290
/// </summary>
public abstract class Conioptilon : Cotingidae, IConioptilon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Conioptilon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 114290;

    /// <inheritdoc />
    public virtual string GenusName => "Conioptilon";

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
