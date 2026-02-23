using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Scyliorhinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Scyliorhinidae.Figaro;

/// <summary>
/// Abstract class for Figaro (genus).
/// NCBI TaxId: 1053878
/// </summary>
public abstract class Figaro : Scyliorhinidae, IFigaro
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Figaro";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1053878;

    /// <inheritdoc />
    public virtual string GenusName => "Figaro";

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
