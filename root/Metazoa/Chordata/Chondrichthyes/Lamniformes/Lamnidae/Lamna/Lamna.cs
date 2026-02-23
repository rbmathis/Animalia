using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Lamniformes.Lamnidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Lamniformes.Lamnidae.Lamna;

/// <summary>
/// Abstract class for Lamna (genus).
/// NCBI TaxId: 7848
/// </summary>
public abstract class Lamna : Lamnidae, ILamna
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lamna";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 7848;

    /// <inheritdoc />
    public virtual string GenusName => "Lamna";

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
