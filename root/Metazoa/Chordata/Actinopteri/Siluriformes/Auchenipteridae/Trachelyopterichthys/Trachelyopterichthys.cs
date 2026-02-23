using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenipteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenipteridae.Trachelyopterichthys;

/// <summary>
/// Abstract class for Trachelyopterichthys (genus).
/// NCBI TaxId: 2382296
/// </summary>
public abstract class Trachelyopterichthys : Auchenipteridae, ITrachelyopterichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trachelyopterichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2382296;

    /// <inheritdoc />
    public virtual string GenusName => "Trachelyopterichthys";

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
