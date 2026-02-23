using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Bucconidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Bucconidae.Nonnula;

/// <summary>
/// Abstract class for Nonnula (genus).
/// NCBI TaxId: 190664
/// </summary>
public abstract class Nonnula : Bucconidae, INonnula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nonnula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 190664;

    /// <inheritdoc />
    public virtual string GenusName => "Nonnula";

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
