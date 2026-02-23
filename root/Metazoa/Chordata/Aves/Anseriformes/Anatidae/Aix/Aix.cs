using AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Aix;

/// <summary>
/// Abstract class for Aix (genus).
/// NCBI TaxId: 8831
/// </summary>
public abstract class Aix : Anatidae, IAix
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aix";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8831;

    /// <inheritdoc />
    public virtual string GenusName => "Aix";

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
