using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Funisciurus;

/// <summary>
/// Abstract class for Funisciurus (genus).
/// NCBI TaxId: 226679
/// </summary>
public abstract class Funisciurus : Sciuridae, IFunisciurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Funisciurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 226679;

    /// <inheritdoc />
    public virtual string GenusName => "Funisciurus";

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
