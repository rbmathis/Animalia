using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Ramphotrigon;

/// <summary>
/// Abstract class for Ramphotrigon (genus).
/// NCBI TaxId: 360231
/// </summary>
public abstract class Ramphotrigon : Tyrannidae, IRamphotrigon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ramphotrigon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 360231;

    /// <inheritdoc />
    public virtual string GenusName => "Ramphotrigon";

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
