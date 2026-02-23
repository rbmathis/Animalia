using AnimalKingdom.root.Metazoa.Chordata.Appendicularia.Copelata.Kowalevskiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Appendicularia.Copelata.Kowalevskiidae.Kowalevskia;

/// <summary>
/// Abstract class for Kowalevskia (genus).
/// NCBI TaxId: 2547644
/// </summary>
public abstract class Kowalevskia : Kowalevskiidae, IKowalevskia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kowalevskia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2547644;

    /// <inheritdoc />
    public virtual string GenusName => "Kowalevskia";

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
