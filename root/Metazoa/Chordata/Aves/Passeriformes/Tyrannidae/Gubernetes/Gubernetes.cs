using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Gubernetes;

/// <summary>
/// Abstract class for Gubernetes (genus).
/// NCBI TaxId: 137525
/// </summary>
public abstract class Gubernetes : Tyrannidae, IGubernetes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gubernetes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 137525;

    /// <inheritdoc />
    public virtual string GenusName => "Gubernetes";

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
