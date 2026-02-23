using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Camptostoma;

/// <summary>
/// Abstract class for Camptostoma (genus).
/// NCBI TaxId: 372287
/// </summary>
public abstract class Camptostoma : Tyrannidae, ICamptostoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Camptostoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 372287;

    /// <inheritdoc />
    public virtual string GenusName => "Camptostoma";

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
