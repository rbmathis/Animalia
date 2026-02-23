using AnimalKingdom.root.Metazoa.Chordata.Hyperoartia.Petromyzontiformes.Petromyzontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Hyperoartia.Petromyzontiformes.Petromyzontidae.Petromyzon;

/// <summary>
/// Abstract class for Petromyzon (genus).
/// NCBI TaxId: 7756
/// </summary>
public abstract class Petromyzon : Petromyzontidae, IPetromyzon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Petromyzon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 7756;

    /// <inheritdoc />
    public virtual string GenusName => "Petromyzon";

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
