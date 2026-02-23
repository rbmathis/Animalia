using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae.Saroglossa;

/// <summary>
/// Abstract class for Saroglossa (genus).
/// NCBI TaxId: 381120
/// </summary>
public abstract class Saroglossa : Sturnidae, ISaroglossa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Saroglossa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 381120;

    /// <inheritdoc />
    public virtual string GenusName => "Saroglossa";

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
