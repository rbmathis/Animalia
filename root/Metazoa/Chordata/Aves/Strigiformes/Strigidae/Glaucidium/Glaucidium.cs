using AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Glaucidium;

/// <summary>
/// Abstract class for Glaucidium (genus).
/// NCBI TaxId: 78216
/// </summary>
public abstract class Glaucidium : Strigidae, IGlaucidium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Glaucidium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 78216;

    /// <inheritdoc />
    public virtual string GenusName => "Glaucidium";

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
