using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Ptychidio;

/// <summary>
/// Abstract class for Ptychidio (genus).
/// NCBI TaxId: 369662
/// </summary>
public abstract class Ptychidio : Cyprinidae, IPtychidio
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ptychidio";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 369662;

    /// <inheritdoc />
    public virtual string GenusName => "Ptychidio";

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
