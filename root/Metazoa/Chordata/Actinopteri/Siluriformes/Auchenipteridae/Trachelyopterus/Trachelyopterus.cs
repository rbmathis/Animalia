using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenipteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenipteridae.Trachelyopterus;

/// <summary>
/// Abstract class for Trachelyopterus (genus).
/// NCBI TaxId: 238650
/// </summary>
public abstract class Trachelyopterus : Auchenipteridae, ITrachelyopterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trachelyopterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 238650;

    /// <inheritdoc />
    public virtual string GenusName => "Trachelyopterus";

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
