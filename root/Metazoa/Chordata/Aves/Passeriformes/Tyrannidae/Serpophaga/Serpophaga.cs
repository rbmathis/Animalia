using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Serpophaga;

/// <summary>
/// Abstract class for Serpophaga (genus).
/// NCBI TaxId: 377291
/// </summary>
public abstract class Serpophaga : Tyrannidae, ISerpophaga
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Serpophaga";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 377291;

    /// <inheritdoc />
    public virtual string GenusName => "Serpophaga";

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
