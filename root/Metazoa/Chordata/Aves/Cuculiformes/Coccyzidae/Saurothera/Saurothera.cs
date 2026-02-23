using AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Coccyzidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Coccyzidae.Saurothera;

/// <summary>
/// Abstract class for Saurothera (genus).
/// NCBI TaxId: 181022
/// </summary>
public abstract class Saurothera : Coccyzidae, ISaurothera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Saurothera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 181022;

    /// <inheritdoc />
    public virtual string GenusName => "Saurothera";

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
