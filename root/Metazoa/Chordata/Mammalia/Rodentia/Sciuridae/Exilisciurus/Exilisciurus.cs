using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Exilisciurus;

/// <summary>
/// Abstract class for Exilisciurus (genus).
/// NCBI TaxId: 226547
/// </summary>
public abstract class Exilisciurus : Sciuridae, IExilisciurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Exilisciurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 226547;

    /// <inheritdoc />
    public virtual string GenusName => "Exilisciurus";

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
