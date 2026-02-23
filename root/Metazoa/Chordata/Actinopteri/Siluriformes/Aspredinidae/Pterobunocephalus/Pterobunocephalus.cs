using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Aspredinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Aspredinidae.Pterobunocephalus;

/// <summary>
/// Abstract class for Pterobunocephalus (genus).
/// NCBI TaxId: 337535
/// </summary>
public abstract class Pterobunocephalus : Aspredinidae, IPterobunocephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pterobunocephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 337535;

    /// <inheritdoc />
    public virtual string GenusName => "Pterobunocephalus";

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
