using AnimalKingdom.root.Metazoa.Chordata.Hyperoartia.Petromyzontiformes.Petromyzontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Hyperoartia.Petromyzontiformes.Petromyzontidae.Eudontomyzon;

/// <summary>
/// Abstract class for Eudontomyzon (genus).
/// NCBI TaxId: 338474
/// </summary>
public abstract class Eudontomyzon : Petromyzontidae, IEudontomyzon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eudontomyzon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 338474;

    /// <inheritdoc />
    public virtual string GenusName => "Eudontomyzon";

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
