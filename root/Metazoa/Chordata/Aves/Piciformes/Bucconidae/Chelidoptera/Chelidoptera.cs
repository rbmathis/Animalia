using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Bucconidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Bucconidae.Chelidoptera;

/// <summary>
/// Abstract class for Chelidoptera (genus).
/// NCBI TaxId: 1032513
/// </summary>
public abstract class Chelidoptera : Bucconidae, IChelidoptera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chelidoptera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1032513;

    /// <inheritdoc />
    public virtual string GenusName => "Chelidoptera";

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
