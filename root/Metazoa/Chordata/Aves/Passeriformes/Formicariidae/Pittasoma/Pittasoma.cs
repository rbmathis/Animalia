using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Formicariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Formicariidae.Pittasoma;

/// <summary>
/// Abstract class for Pittasoma (genus).
/// NCBI TaxId: 255372
/// </summary>
public abstract class Pittasoma : Formicariidae, IPittasoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pittasoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 255372;

    /// <inheritdoc />
    public virtual string GenusName => "Pittasoma";

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
