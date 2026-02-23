using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Aegithalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Aegithalidae.Psaltria;

/// <summary>
/// Abstract class for Psaltria (genus).
/// NCBI TaxId: 1980978
/// </summary>
public abstract class Psaltria : Aegithalidae, IPsaltria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Psaltria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1980978;

    /// <inheritdoc />
    public virtual string GenusName => "Psaltria";

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
