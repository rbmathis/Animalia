using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Macroscelidea.Macroscelididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Macroscelidea.Macroscelididae.Petrodromus;

/// <summary>
/// Abstract class for Petrodromus (genus).
/// NCBI TaxId: 113271
/// </summary>
public abstract class Petrodromus : Macroscelididae, IPetrodromus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Petrodromus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 113271;

    /// <inheritdoc />
    public virtual string GenusName => "Petrodromus";

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
