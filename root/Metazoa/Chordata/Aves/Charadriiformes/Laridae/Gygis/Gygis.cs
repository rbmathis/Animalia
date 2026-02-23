using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Gygis;

/// <summary>
/// Abstract class for Gygis (genus).
/// NCBI TaxId: 297808
/// </summary>
public abstract class Gygis : Laridae, IGygis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gygis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 297808;

    /// <inheritdoc />
    public virtual string GenusName => "Gygis";

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
