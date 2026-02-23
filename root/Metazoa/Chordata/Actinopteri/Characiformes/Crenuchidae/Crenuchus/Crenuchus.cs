using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Crenuchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Crenuchidae.Crenuchus;

/// <summary>
/// Abstract class for Crenuchus (genus).
/// NCBI TaxId: 909853
/// </summary>
public abstract class Crenuchus : Crenuchidae, ICrenuchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Crenuchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 909853;

    /// <inheritdoc />
    public virtual string GenusName => "Crenuchus";

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
