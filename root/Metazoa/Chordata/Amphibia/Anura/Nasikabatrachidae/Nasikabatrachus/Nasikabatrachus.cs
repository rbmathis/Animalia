using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Nasikabatrachidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Nasikabatrachidae.Nasikabatrachus;

/// <summary>
/// Abstract class for Nasikabatrachus (genus).
/// NCBI TaxId: 251753
/// </summary>
public abstract class Nasikabatrachus : Nasikabatrachidae, INasikabatrachus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nasikabatrachus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 251753;

    /// <inheritdoc />
    public virtual string GenusName => "Nasikabatrachus";

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
