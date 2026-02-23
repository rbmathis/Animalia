using AnimalKingdom.root.Metazoa.Chordata.Hyperoartia.Petromyzontiformes.Petromyzontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Hyperoartia.Petromyzontiformes.Petromyzontidae.Mordacia;

/// <summary>
/// Abstract class for Mordacia (genus).
/// NCBI TaxId: 7754
/// </summary>
public abstract class Mordacia : Petromyzontidae, IMordacia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mordacia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 7754;

    /// <inheritdoc />
    public virtual string GenusName => "Mordacia";

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
