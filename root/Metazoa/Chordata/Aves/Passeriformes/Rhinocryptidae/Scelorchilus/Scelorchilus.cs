using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Rhinocryptidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Rhinocryptidae.Scelorchilus;

/// <summary>
/// Abstract class for Scelorchilus (genus).
/// NCBI TaxId: 112108
/// </summary>
public abstract class Scelorchilus : Rhinocryptidae, IScelorchilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scelorchilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 112108;

    /// <inheritdoc />
    public virtual string GenusName => "Scelorchilus";

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
