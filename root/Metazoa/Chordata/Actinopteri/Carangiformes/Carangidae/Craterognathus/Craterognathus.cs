using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Craterognathus;

/// <summary>
/// Abstract class for Craterognathus (genus).
/// NCBI TaxId: 3040445
/// </summary>
public abstract class Craterognathus : Carangidae, ICraterognathus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Craterognathus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3040445;

    /// <inheritdoc />
    public virtual string GenusName => "Craterognathus";

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
