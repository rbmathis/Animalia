using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Parioglossus;

/// <summary>
/// Abstract class for Parioglossus (genus).
/// NCBI TaxId: 1004040
/// </summary>
public abstract class Parioglossus : Gobiidae, IParioglossus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parioglossus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1004040;

    /// <inheritdoc />
    public virtual string GenusName => "Parioglossus";

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
