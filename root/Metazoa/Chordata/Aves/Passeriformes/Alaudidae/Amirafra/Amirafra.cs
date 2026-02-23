using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Alaudidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Alaudidae.Amirafra;

/// <summary>
/// Abstract class for Amirafra (genus).
/// NCBI TaxId: 3390988
/// </summary>
public abstract class Amirafra : Alaudidae, IAmirafra
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Amirafra";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3390988;

    /// <inheritdoc />
    public virtual string GenusName => "Amirafra";

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
