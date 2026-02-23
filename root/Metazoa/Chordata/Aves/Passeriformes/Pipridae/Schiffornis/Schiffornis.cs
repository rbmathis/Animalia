using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pipridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pipridae.Schiffornis;

/// <summary>
/// Abstract class for Schiffornis (genus).
/// NCBI TaxId: 114384
/// </summary>
public abstract class Schiffornis : Pipridae, ISchiffornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Schiffornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 114384;

    /// <inheritdoc />
    public virtual string GenusName => "Schiffornis";

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
