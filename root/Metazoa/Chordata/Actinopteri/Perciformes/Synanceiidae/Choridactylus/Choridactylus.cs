using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Synanceiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Synanceiidae.Choridactylus;

/// <summary>
/// Abstract class for Choridactylus (genus).
/// NCBI TaxId: 1003943
/// </summary>
public abstract class Choridactylus : Synanceiidae, IChoridactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Choridactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1003943;

    /// <inheritdoc />
    public virtual string GenusName => "Choridactylus";

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
