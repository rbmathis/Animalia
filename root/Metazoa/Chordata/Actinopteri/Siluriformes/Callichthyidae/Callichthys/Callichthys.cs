using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Callichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Callichthyidae.Callichthys;

/// <summary>
/// Abstract class for Callichthys (genus).
/// NCBI TaxId: 245774
/// </summary>
public abstract class Callichthys : Callichthyidae, ICallichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Callichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 245774;

    /// <inheritdoc />
    public virtual string GenusName => "Callichthys";

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
