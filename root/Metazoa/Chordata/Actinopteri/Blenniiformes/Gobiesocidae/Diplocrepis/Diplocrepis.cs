using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae.Diplocrepis;

/// <summary>
/// Abstract class for Diplocrepis (genus).
/// NCBI TaxId: 2740775
/// </summary>
public abstract class Diplocrepis : Gobiesocidae, IDiplocrepis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Diplocrepis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2740775;

    /// <inheritdoc />
    public virtual string GenusName => "Diplocrepis";

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
