using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Phlebobranchia.Ascidiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Phlebobranchia.Ascidiidae.Phallusia;

/// <summary>
/// Abstract class for Phallusia (genus).
/// NCBI TaxId: 56696
/// </summary>
public abstract class Phallusia : Ascidiidae, IPhallusia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phallusia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 56696;

    /// <inheritdoc />
    public virtual string GenusName => "Phallusia";

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
