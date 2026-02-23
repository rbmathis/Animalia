using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Glareolidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Glareolidae.Glareola;

/// <summary>
/// Abstract class for Glareola (genus).
/// NCBI TaxId: 43315
/// </summary>
public abstract class Glareola : Glareolidae, IGlareola
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Glareola";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 43315;

    /// <inheritdoc />
    public virtual string GenusName => "Glareola";

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
