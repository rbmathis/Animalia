using AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Cerylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Cerylidae.Megaceryle;

/// <summary>
/// Abstract class for Megaceryle (genus).
/// NCBI TaxId: 176941
/// </summary>
public abstract class Megaceryle : Cerylidae, IMegaceryle
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Megaceryle";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 176941;

    /// <inheritdoc />
    public virtual string GenusName => "Megaceryle";

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
