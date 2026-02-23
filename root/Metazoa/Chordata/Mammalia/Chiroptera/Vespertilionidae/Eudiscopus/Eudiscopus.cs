using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Eudiscopus;

/// <summary>
/// Abstract class for Eudiscopus (genus).
/// NCBI TaxId: 633650
/// </summary>
public abstract class Eudiscopus : Vespertilionidae, IEudiscopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eudiscopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 633650;

    /// <inheritdoc />
    public virtual string GenusName => "Eudiscopus";

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
