using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Platyrinchus;

/// <summary>
/// Abstract class for Platyrinchus (genus).
/// NCBI TaxId: 360227
/// </summary>
public abstract class Platyrinchus : Tyrannidae, IPlatyrinchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Platyrinchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 360227;

    /// <inheritdoc />
    public virtual string GenusName => "Platyrinchus";

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
