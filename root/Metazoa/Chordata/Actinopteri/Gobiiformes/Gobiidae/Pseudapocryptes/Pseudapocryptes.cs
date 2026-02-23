using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Pseudapocryptes;

/// <summary>
/// Abstract class for Pseudapocryptes (genus).
/// NCBI TaxId: 166759
/// </summary>
public abstract class Pseudapocryptes : Gobiidae, IPseudapocryptes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudapocryptes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 166759;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudapocryptes";

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
