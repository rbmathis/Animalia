using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Pinguinus;

/// <summary>
/// Abstract class for Pinguinus (genus).
/// NCBI TaxId: 94622
/// </summary>
public abstract class Pinguinus : Laridae, IPinguinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pinguinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 94622;

    /// <inheritdoc />
    public virtual string GenusName => "Pinguinus";

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
