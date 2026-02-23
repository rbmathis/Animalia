using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Clariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Clariidae.Prophagorus;

/// <summary>
/// Abstract class for Prophagorus (genus).
/// NCBI TaxId: 337886
/// </summary>
public abstract class Prophagorus : Clariidae, IProphagorus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Prophagorus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 337886;

    /// <inheritdoc />
    public virtual string GenusName => "Prophagorus";

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
