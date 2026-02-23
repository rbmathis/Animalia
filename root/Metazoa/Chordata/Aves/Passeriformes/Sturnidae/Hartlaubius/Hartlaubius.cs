using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae.Hartlaubius;

/// <summary>
/// Abstract class for Hartlaubius (genus).
/// NCBI TaxId: 1851195
/// </summary>
public abstract class Hartlaubius : Sturnidae, IHartlaubius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hartlaubius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1851195;

    /// <inheritdoc />
    public virtual string GenusName => "Hartlaubius";

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
