using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Psammodromus;

/// <summary>
/// Abstract class for Psammodromus (genus).
/// NCBI TaxId: 80459
/// </summary>
public abstract class Psammodromus : Lacertidae, IPsammodromus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Psammodromus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 80459;

    /// <inheritdoc />
    public virtual string GenusName => "Psammodromus";

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
