using AnimalKingdom.root.Metazoa.Chordata.Aves.Otidiformes.Otididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Otidiformes.Otididae.Tetrax;

/// <summary>
/// Abstract class for Tetrax (genus).
/// NCBI TaxId: 172683
/// </summary>
public abstract class Tetrax : Otididae, ITetrax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tetrax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 172683;

    /// <inheritdoc />
    public virtual string GenusName => "Tetrax";

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
