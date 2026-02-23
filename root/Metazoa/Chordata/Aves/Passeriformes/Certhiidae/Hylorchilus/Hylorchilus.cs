using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Certhiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Certhiidae.Hylorchilus;

/// <summary>
/// Abstract class for Hylorchilus (genus).
/// NCBI TaxId: 2821866
/// </summary>
public abstract class Hylorchilus : Certhiidae, IHylorchilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hylorchilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2821866;

    /// <inheritdoc />
    public virtual string GenusName => "Hylorchilus";

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
