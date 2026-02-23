using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Alepes;

/// <summary>
/// Abstract class for Alepes (genus).
/// NCBI TaxId: 173326
/// </summary>
public abstract class Alepes : Carangidae, IAlepes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Alepes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 173326;

    /// <inheritdoc />
    public virtual string GenusName => "Alepes";

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
