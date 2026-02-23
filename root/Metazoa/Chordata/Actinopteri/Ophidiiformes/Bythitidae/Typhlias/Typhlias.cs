using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Bythitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Bythitidae.Typhlias;

/// <summary>
/// Abstract class for Typhlias (genus).
/// NCBI TaxId: 2924046
/// </summary>
public abstract class Typhlias : Bythitidae, ITyphlias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Typhlias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2924046;

    /// <inheritdoc />
    public virtual string GenusName => "Typhlias";

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
